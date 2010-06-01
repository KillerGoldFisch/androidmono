MONO_SVN_BASE=svn://anonsvn.mono-project.com/source/trunk
echo =====CHECKING OUT MONO FROM $MONO_SVN_BASE=====
if [ -z $USE_LATEST_MONO ]
then
    MONO_SVN_REVISION="-r 157341"
    echo =====USING SUPPORTED REVISION OF MONO: $MONO_SVN_REVISION=====
else
    echo =====USING LATEST REVISION OF MONO! THIS MAY NOT BE STABLE!=====
fi

pushd $(dirname $0)/jni

function checkresult
{
    RESULT=`echo $?`
    if [ "$RESULT" != 0 ]; then
        echo $1
        exit $RESULT
    fi
}

echo
echo =====CHECKING OUT MONO=====
if [ -d mono ]
then
    echo =====UPDATING EXISTING MONO CHECKOUT=====
    echo =====If you get errors, you may want to delete mono and hostbuild to force a clean build=====
    pushd mono
    MONO_SKIP_PATCH=true
    svn up $MONO_SVN_REVISION
    popd
    checkresult 'Error while updating ./mono'
    pushd ../hostbuild/mono
    svn up $MONO_SVN_REVISION
    popd
    checkresult 'Error while updating ./hostbuild/mono'
    pushd ../hostbuild/mcs
    svn up $MONO_SVN_REVISION
    popd
    checkresult 'Error while updating ./hostbuild/mcs'
else
    svn co $MONO_SVN_REVISION $MONO_SVN_BASE/mono
    mkdir -p ../hostbuild
    cp -r mono ../hostbuild/mono
    pushd ../hostbuild
    svn co $MONO_SVN_REVISION $MONO_SVN_BASE/mcs
    popd
fi

echo
echo =====COMPILING MONO CLASS LIBRARIES FOR MCS BUILD=====
sleep 2
pushd ../hostbuild/mono/eglib
if [ ! -f configure ]
then
    ./autogen.sh
fi
popd

mkdir -p ../hostbuild/install
pushd ../hostbuild/install
INSTALL_PREFIX=$(pwd)
echo INSTALL_PREFIX=$INSTALL_PREFIX
popd

pushd ../hostbuild/mono
UNAME=$(uname -a | grep Darwin | grep x86_64)
if [ ! -z "$UNAME" ]
then
    echo Using gcc-4.0 on Darwin x86_64!
    export CC=gcc-4.0
fi
if [ ! -f configure ]
then
    ./autogen.sh --with-glib=embedded --with-moonlight=no --prefix=$INSTALL_PREFIX
fi
make && make install
popd

if [ ! -f mono.patch ]
then
    echo =====NO LOCAL MONO PATCH FOUND=====
    MONO_SKIP_PATCH=true
fi

if [ -z $MONO_SKIP_PATCH ]
then
    pushd mono
    echo
    echo =====APPLYING ANDROID PATCHES FOR ARM BUILD=====
    patch -p0 -i ../mono.patch
    popd
fi

echo "=====Done! Don't forget Rebuild the ARM build using the Android NDK now!====="