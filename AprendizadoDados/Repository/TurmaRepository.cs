using Newtonsoft.Json;
using AprendizadoDados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AprendizadoDados.Repository
{
    public class TurmaRepository
    {
        public void ExportarJson(Turma turma)
        {
            var json = JsonConvert.SerializeObject(turma, Formatting.Indented);
            using(var streamWriter = new StreamWriter($"C:\\temp2\\turma_{turma.IdTurma}.json"))
            {
                streamWriter.WriteLine(json);
            }

        }

        public void ExportarXml(Turma turma)
        {
            var xml = new XmlSerializer(typeof(Turma));
            using (var streamWriter = new StreamWriter($"C:\\temp2\\turma_{turma.IdTurma}.xml"))
            {
                xml.Serialize(streamWriter, turma);
            } 
        }
    }
}
