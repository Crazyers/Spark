using System;
using System.ComponentModel.DataAnnotations;

namespace Spark.Config.Api.Entity
{
    ///<summary>
    ///MsService
    ///</summary>
    public class MsService
    {
        public MsService()
        {
            AddTime = DateTime.Now;
            UpdateTime = DateTime.Now;
        }

        ///<summary>
        ///
        ///</summary>
        public long Id { get; set; }

        ///<summary>
        ///
        ///</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name����Ϊ�գ�")]
        public string Name { get; set; }

        ///<summary>
        ///
        ///</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ip����Ϊ�գ�")]
        public string Ip { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Port����Ϊ�գ�")]
        public int Port { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int Status { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Remark { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime AddTime { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime UpdateTime { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "App����Ϊ�գ�")]
        public string App { get; set; }
    }
}