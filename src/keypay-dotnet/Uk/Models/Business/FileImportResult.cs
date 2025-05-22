using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class FileImportResult
    {
        public List<String> Errors { get; set; }
        public int Created { get; set; }
        public int Updated { get; set; }
        public List<String> Warnings { get; set; }
        public IList<ImportedRecordMetaDataViewModel> CreatedRecordsMetaData { get; set; }
        public IList<ImportedRecordMetaDataViewModel> UpdatedRecordsMetaData { get; set; }
    }
}
