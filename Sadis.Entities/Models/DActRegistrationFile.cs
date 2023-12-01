using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DActRegistrationFile
{
    public int CActRegistrationFile { get; set; }

    public int CAct { get; set; }

    public int CUser { get; set; }

    public string UserDisplayName { get; set; } = null!;

    public string UploadedFileName { get; set; } = null!;

    public string ServerFilePath { get; set; } = null!;

    public string ServerFileName { get; set; } = null!;

    public int ContentLengthKb { get; set; }

    public DAct CActNavigation { get; set; } = null!;
}
