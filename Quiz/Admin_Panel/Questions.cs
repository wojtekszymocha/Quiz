using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Questions
    {
        public int questions_id { get; set; }
        public string questions_title{ get; set; }
        public string questions_option_A{ get; set; }
        public string questions_option_B{ get; set; }
        public string questions_option_C{ get; set; }
        public string questions_option_D{ get; set; }
        public string questions_option_correct{ get; set; }
        public string questions_addeddate{ get; set; }
        public string questions_fk_admin{ get; set; }
        public string questions_fk_exam{ get; set; }
    }
}
