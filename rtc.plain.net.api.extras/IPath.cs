using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtc.plain.net.api.extras
{
    public abstract class IPath : ICloneable
    {
        public const char SEPARATOR = '/';
        public const char DEVICE_SEPARATOR = ':';

        public abstract IPath addFileExtension(String paramString);

        public abstract IPath addTrailingSeparator();

        public abstract IPath append(String paramString);

        public abstract IPath append(IPath paramIPath);

        public abstract Object clone();

        public abstract bool equals(Object paramObject);

        public abstract String getDevice();

        public abstract String getFileExtension();

        public abstract bool hasTrailingSeparator();

        public abstract bool isAbsolute();

        public abstract bool isEmpty();

        public abstract bool isPrefixOf(IPath paramIPath);

        public abstract bool isRoot();

        public abstract bool isUNC();

        public abstract bool isValidPath(String paramString);

        public abstract bool isValidSegment(String paramString);

        public abstract String lastSegment();

        public abstract IPath makeAbsolute();

        public abstract IPath makeRelative();

        public abstract IPath makeRelativeTo(IPath paramIPath);

        public abstract IPath makeUNC(bool parambool);

        public abstract int matchingFirstSegments(IPath paramIPath);

        public abstract IPath removeFileExtension();

        public abstract IPath removeFirstSegments(int paramInt);

        public abstract IPath removeLastSegments(int paramInt);

        public abstract IPath removeTrailingSeparator();

        public abstract String segment(int paramInt);

        public abstract int segmentCount();

        public abstract String[] segments();

        public abstract IPath setDevice(String paramString);

        public abstract FileInfo toFile();

        public abstract String toOSString();

        public abstract String toPortableString();

        public abstract String toString();

        public abstract IPath uptoSegment(int paramInt);

        public abstract Object Clone();
    }
}

