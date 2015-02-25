using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace SerializationDemo
{
	class Program
	{
		static void Main()
		{
			ServiceConfiguration config = new ServiceConfiguration()
			{
				ApplicationDataPath = @"C:\Data",
				ConfigName = "Teste",
				DatabaseHostName = "host1"
			};

			Serialize(config);
			var config2 = Deserialize();
		}

		static void Serialize(ServiceConfiguration config)
		{
			var jsonSerializer = new DataContractJsonSerializer(config.GetType());
			FileStream buffer = File.Create("E:\\config.json");
			jsonSerializer.WriteObject(buffer, config);
			buffer.Close();
		}

		static ServiceConfiguration Deserialize()
		{
			var jsonSerializer = new DataContractJsonSerializer(typeof(ServiceConfiguration));
			FileStream buffer = File.OpenRead("E:\\config.json");
			var config = jsonSerializer.ReadObject(buffer) as ServiceConfiguration;
			buffer.Close();
			return config;
		}
	}
}
