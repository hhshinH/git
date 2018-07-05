using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace UserInformation_Project.UIP.EMail
{
	public class EMail
	{
	public static void SendMail(string AdminEMail, string AdminPW, string subject, string body,
            string FileName, byte[] FileByte,
            string ImageName, byte[] ImageByte)
        {
            var fromAddress = new MailAddress(AdminEMail, "From Name");
            var toAddress = new MailAddress(AdminEMail, "To Name");

            string Default = @"D:\wwwRoot\HUEN\PEDAS\Temp\";

            if (FileName != string.Empty && FileName != ".zip")
            {
                using (var fs = new FileStream(Default + FileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(FileByte, 0, FileByte.Length);
                }
            }

            if (ImageName != string.Empty)
            {
                using (var fs = new FileStream(Default + ImageName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(ImageByte, 0, ImageByte.Length);
                }
            }

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, AdminPW),
                Timeout = 200000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
            })
            {
                try
                {
                    if (FileName != string.Empty)
                    {
                        FileStream fs = new FileStream(Default + FileName, FileMode.Open);
                        var attachment = new System.Net.Mail.Attachment(fs, FileName, "text/text");
                        message.Attachments.Add(attachment);
                    }

                    if (ImageName != string.Empty)
                    {
                        FileStream fs = new FileStream(Default + ImageName, FileMode.Open);
                        var attachment = new System.Net.Mail.Attachment(fs, ImageName, "text/text");
                        message.Attachments.Add(attachment);
                    }

                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    try
                    {
                        //첨부파일때문에 오류발생할경우 내용만 보냄
                        message.Attachments.Clear();

                        if (ImageName != string.Empty)
                        {
                            FileStream fs = new FileStream(Default + ImageName, FileMode.Open);
                            var attachment = new System.Net.Mail.Attachment(fs, ImageName, "text/text");
                            message.Attachments.Add(attachment);
                        }

                        smtp.Send(message);
                    }
                    catch (Exception ex2)
                    {

                    }
                }
            }
        }




	}
}

