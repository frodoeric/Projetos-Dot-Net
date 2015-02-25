using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParameterPassing.Tests
{
    [TestClass]
    public class UnitTest1
    {
        struct IntHolder
        {
            public int I;
        }

        void Foo(IntHolder x)
        {
            x.I = 10;
        }

        void Foo(StringBuilder x)
        {
            x = null;
        }

        void Foo(ref StringBuilder x)
        {
            x = null;
        }

        void Foo(ref IntHolder x)
        {
            x.I = 10;
        }

        [TestMethod]
        public void ComportamentoDosTiposDeValor()
        {
            int x = 5;

            int y = x;

            x = 6;

            // x e y NÃO têm o mesmo valor
            Assert.AreNotEqual(x, y);
            Assert.AreEqual(6, x);
            Assert.AreEqual(5, y);
        }

        [TestMethod]
        public void ComportamentoDosTiposDeReferencia()
        {
            var sb1 = new StringBuilder();
            sb1.Append("Olá");

            var sb2 = sb1;

            sb1.Append(" mundo");

            // sb1 e sb2 têm o mesmo valor
            Assert.AreEqual(sb1.ToString(), sb2.ToString());
            Assert.AreEqual(sb1.ToString(), "Olá mundo");
            Assert.AreEqual(sb2.ToString(), "Olá mundo");
        }

        [TestMethod]
        public void ValueTypePassedByValue()
        {
            // IntHolder é uma struct, um tipo de valor (value type)
            var y = new IntHolder();
            y.I = 5;

            Foo(y);

            // Foo recebe um "value type" "by value"
            // portanto o valor de y.I não é alterado fora 
            // do escopo da função Foo()

            Assert.AreEqual(y.I, 5);
        }

        [TestMethod]
        public void ReferenceTypePassedByValue()
        {
            // StringBuilder é um tipo de referência (reference type)
            var y = new StringBuilder();
            y.Append("hello");

            Foo(y);

            // O método Foo() seta o parametro recebido para null,
            // mas, como o objeto y foi passado "by value", 
            // ele não é alterado fora do escopo do método,
            // portanto não é setado como null fora do método Foo()

            Assert.IsNotNull(y);
        }

        [TestMethod]
        public void ReferenceTypePassedByReference()
        {
            // StringBuilder é um tipo de referência (reference type)
            var y = new StringBuilder();
            y.Append("hello");

            Foo(ref y);

            // O método Foo() recebe um parâmetro "by reference"
            // e o seta como null. Pelo fato de o parâmetro ter sido
            // passado como a keywork "ref" a variável também é alterada
            // fora do método Foo();

            Assert.IsNull(y);
        }

        [TestMethod]
        public void ValueTypePassedByReference()
        {
            // IntHolder é uma struct, um tipo de valor (value type)
            var y = new IntHolder();
            y.I = 5;

            Foo(ref y);

            // O método Foo() recebe um parâmetro "by reference"
            // e o seta como 10. Pelo fato de o parâmetro ter sido
            // passado como a keywork "ref" a variável também é alterada
            // fora do método Foo();

            Assert.AreEqual(y.I, 10);
        }
    }
}
