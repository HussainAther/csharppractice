        public static string MakeExperiments(NetLogo netLogo)
        {
            string content = netLogo.Content;
            string experiments = netLogo.Experiments;
            string tmpstr1 = content.Substring(0, content.IndexOf("@#$#@#$#@\r\n@#$#@#$#@") + "@#$#@#$#@\r\n@#$#@#$#@".Length);
            string tmpstr2 = content.Substring((content.IndexOf("@#$#@#$#@\r\n@#$#@#$#@") + "@#$#@#$#@\r\n@#$#@#$#@".Length), (content.Length - content.IndexOf("@#$#@#$#@\r\n@#$#@#$#@") - "@#$#@#$#@\r\n@#$#@#$#@".Length));
            //JArray ja = (JArray)JsonConvert.DeserializeObject(experiments);
            StringBuilder sb = new StringBuilder();
            sb.Append("\r\n<experiments>");
            JArray ja = JArray.Parse(experiments);
            foreach (JObject jo in ja)
            {
                string experiment = "";
                experiment += "\r\n  <experiment name=\"" + jo["name"].ToString() + "\" repetitions=\"" + jo["repetitions"].ToString() + "\" runMetricsEveryStep=\"" + jo["runMetricsEveryStep"] + "\">";
                experiment += "\r\n    <setup>" + jo["setup"].ToString() + "</setup>";
                experiment += "\r\n    <go>" + jo["go"].ToString() + "</go>";
                if (!jo["timeLimit"].ToString().Equals("") && jo["timeLimit"].ToString() != null)
                {
                    experiment += "\r\n    <timeLimit steps=\"" + jo["timeLimit"].ToString() + "\" />";
                }
                if (!jo["exitCondition"].ToString().Equals("") && jo["exitCondition"].ToString() != null)
                {
                    experiment += "\r\n    <exitCondition>" + jo["exitCondition"].ToString() + "</exitCondition>";
                }
                string[] metrics = jo["metric"].ToString().Split('\n');
                foreach (string metric in metrics)
                {
                    experiment += "\r\n    <metric>" + Regex.Replace(metric, @"[\r]", "") + "</metric>";
                }

                string[] enumeratedValueSets = jo["enumeratedValueSet"].ToString().Split('\n');
                foreach (string evs in enumeratedValueSets)
                {
                    string e = evs.Substring(evs.IndexOf("\"") + 1, evs.LastIndexOf("\"") - evs.IndexOf("\"") - 1);
                    experiment += "\r\n    <enumeratedValueSet variable=\"" + e + "\" >";
                    string[] values = evs.Substring(evs.LastIndexOf("\"") + 2, evs.Length - evs.LastIndexOf("\"") - 3).Split(' ');
                    foreach (var value in values)
                    {
                        experiment += "\r\n      <value value=\"" + Regex.Replace(value, @"]", "") + "\" />";
                    }
                    experiment += "\r\n    </enumeratedValueSet>";
                }
                experiment += "\r\n  </experiment>";
                sb.Append(experiment);
            }
            sb.Append("\r\n</experiments>");

            return tmpstr1 + "\r\n@#$#@#$#@" + sb.ToString() + "\r\n@#$#@#$#@\r\n@#$#@#$#@" + tmpstr2;
        }
