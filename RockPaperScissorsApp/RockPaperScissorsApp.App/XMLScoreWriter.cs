namespace RockPaperScissorsApp.App
{
    public class XMLScoreWriter
    {
        public string Scores { get; set; }

        public XMLScoreWriter()
        {
            Scores = "";
        }
        
        public XMLScoreWriter (string scores)
        {
            Scores = scores;
        }

        public string ScoresWriter()
        {
            XMLScoreWriter summery = new XMLScoreWriter(Scores);

            summery.Scores = Scores;

            string path = "./Scores.xml";
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(XMLScoreWriter));
                        XMLScoreWriter? summeryFromFile = reader.Deserialize(sr) as XMLScoreWriter;
                        sr.Close();
                        summery.Scores += summeryFromFile?.Scores;
                    }
                }
                using (FileStream fs = File.Create(path))
                {
                    System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(XMLScoreWriter));
                    writer.Serialize(fs, summery);
                    fs.Close();
                }
                using (StreamReader sr = new StreamReader(path))
                {
                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(XMLScoreWriter));
                    XMLScoreWriter? summeryFromFile = reader.Deserialize(sr) as XMLScoreWriter;
                    sr.Close();
                    if(summeryFromFile != null)
                    {
                        summery.Scores = summeryFromFile.Scores;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return summery.Scores;
        }
    }
}
