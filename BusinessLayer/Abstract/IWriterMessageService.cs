﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterMessageService : IGenericService<WriterMessage>
    {
        List<WriterMessage> GetListSenderMessages(string mail);
        List<WriterMessage> GetListReceiverMessage(string mail);
    }
}
