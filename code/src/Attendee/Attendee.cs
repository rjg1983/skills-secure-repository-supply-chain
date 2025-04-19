using System;
using System.IO;
using System.IO.Compression;

namespace Attendees
{

    public class Attendee
    {
        public void WriteToDirectory(ZipArchiveEntry entry, string destDirectory)
        {
            string destFileName = Path.GetFullPath(Path.Combine(destDirectory, entry.FullName));
            string fullDestDirPath = Path.GetFullPath(destDirectory + Path.DirectorySeparatorChar);
            if (!destFileName.StartsWith(fullDestDirPath, StringComparison.Ordinal))
            {
                throw new InvalidOperationException("Entry is outside the target directory: " + destFileName);
            }
            entry.ExtractToFile(destFileName);
        }
        
        public bool AddAttendee(string added)
        {
            if (added == "exists") {
                  return true;
            }
            return false;
        }      
    }
}