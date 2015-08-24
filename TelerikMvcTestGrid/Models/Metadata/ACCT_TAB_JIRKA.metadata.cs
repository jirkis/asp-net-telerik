using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelerikMvcTestGrid.Models
{
    [MetadataTypeAttribute(typeof(ACCT_TAB_JIRKA.Metadata))]
    public partial class ACCT_TAB_JIRKA
    {

        private sealed class Metadata
        {
            [Display(Name = "Aacct")]
            public string AACCT { get; set; }
            [Display(Name = "Awdl Start")]
            public long ABAL { get; set; }
            [Display(Name = "Arest")]
            public int AREST { get; set; }
            [Display(Name = "Awdl Start")]
            public int AWDL_START { get; set; }
            [Display(Name = "Awdl Length")]
            public int AWDL_LEN { get; set; }
            [Display(Name = "Awdl Limit")]
            public long AWDL_LMT { get; set; }
            [Display(Name = "Awdl Tdy")]
            public long AWDL_TDY { get; set; }
            [Display(Name = "Trans Date")]
            public Nullable<int> TRN_DT { get; set; }
            [Display(Name = "Pos Start")]
            public int POS_START { get; set; }
            [Display(Name = "Pos Length")]
            public int POS_LEN { get; set; }
            [Display(Name = "Pos Limit")]
            public long POS_LMT { get; set; }
            [Display(Name = "Pos Tdy")]
            public long POS_TDY { get; set; }
            [Display(Name = "Currency Type")]
            public int CURRENCY_TYPE { get; set; }
            [Display(Name = "Hold Amount")]
            public Nullable<long> HOLD_AMOUNT { get; set; }
            [Display(Name = "Actual balance")]
            public Nullable<long> ACTUAL_BAL { get; set; }
            [Display(Name = "Last Update")]
            [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:u}", ApplyFormatInEditMode = true)]
            public Nullable<System.DateTime> LAST_UPDATE { get; set; }
            [Display(Name = "Acct Segment")]
            public Nullable<int> ACCT_SEGMENT { get; set; }
        }
    }
}