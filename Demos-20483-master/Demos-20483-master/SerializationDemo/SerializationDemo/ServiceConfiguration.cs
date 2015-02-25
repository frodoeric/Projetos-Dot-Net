using System;
using System.Runtime.Serialization;

namespace SerializationDemo
{
	[Serializable]
	public class ServiceConfiguration : ISerializable
	{
		[NonSerialized]
		private Guid _internalId;
		public string ConfigName { get; set; }
		public string DatabaseHostName { get; set; }
		public string ApplicationDataPath { get; set; }
		public ServiceConfiguration()
		{
		}
		public ServiceConfiguration(SerializationInfo info, StreamingContext ctxt)
		{
			ConfigName = info.GetValue("ConfigName", typeof(string)).ToString();
			DatabaseHostName = info.GetValue("DatabaseHostName", typeof(string)).ToString();
			ApplicationDataPath = info.GetValue("ApplicationDataPath", typeof(string)).ToString();
		}
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("ConfigName", this.ConfigName);
			info.AddValue("DatabaseHostName", this.DatabaseHostName);
			info.AddValue("ApplicationDataPath", this.ApplicationDataPath);
		}
	}
}