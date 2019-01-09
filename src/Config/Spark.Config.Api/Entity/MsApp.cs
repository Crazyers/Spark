using System;
using System.ComponentModel.DataAnnotations;

namespace Spark.Config.Api.Entity
{
    ///<summary>
    ///MsApp
    ///</summary>
    public class MsApp
    {
        public MsApp()
        {
            AddTime = DateTime.Now;
            UpdateTime = DateTime.Now;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Code����Ϊ�գ�", AllowEmptyStrings = false)]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name����Ϊ�գ�", AllowEmptyStrings = false)]
        public string Name { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public string Remark { get; set; }
    }
}