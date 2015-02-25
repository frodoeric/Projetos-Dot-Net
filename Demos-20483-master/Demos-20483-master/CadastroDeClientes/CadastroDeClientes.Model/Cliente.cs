using System.Runtime.Serialization;

namespace CadastroDeClientes.Model
{
	[DataContract]
	public class Cliente
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Nome { get; set; }
		[DataMember]
		public string Sobrenome { get; set; }
	}
}
