﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JianShuCore.Model
{
    public class User
    {
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("nickname")]
        public string Nickname
        {
            get;
            set;
        }

        [JsonProperty("avatar")]
        public string Avatar
        {
            get;
            set;
        }
        [JsonProperty("sns_nicknames")]
        public SnsNicknames SnsNicknames
        {
            get; set;
        }
    }
}
