﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spark.Utility.Smtp
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string[] to, string[] cc, string[] bcc, string subject, string message, params Attachment[] Attachments);

        Task SendEmailAsync(string to, string cc, string bcc, string subject, string message, params Attachment[] Attachments);

        Task SendEmailAsync(string to, string subject, string message, params Attachment[] Attachments);

        Task PostEmailAsync(string name, string[] to, string[] cc, string[] bcc, string subject, string message, params Attachment[] Attachments);

        Task PostEmailAsync(string name, string to, string cc, string bcc, string subject, string message, params Attachment[] Attachments);

        Task PostEmailAsync(string name, string to, string subject, string message, params Attachment[] Attachments);
    }
}
