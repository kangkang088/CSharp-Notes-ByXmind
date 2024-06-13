using System;
using System.Collections.Generic;
using System.Text;

namespace Json操作
{
    class Hero
    {
        public string name { get; set; }
        public int maxHP { get; set; }
        public string type { get; set; }
        public List<Skill> skillList { get; set; }
    }
}
