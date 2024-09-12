using PodeVotar;

namespace PodeVotarTest
{
    public class PodeVotarTest
    {
        public class VotoTests
        {
            [Fact]
            public void TestPodeVotar_Idade11_NaoPodeVotar()
            {
                // Arrange
                int idade = 11;
                string esperado = "Não pode votar!";

                // Act
                string obtido = Voto.podeVotar(idade);

                // Assert
                Assert.Equal(esperado,obtido);
            }

            [Fact]
            public void TestPodeVotar_Idade16_VotoOpcional()
            {
                // Arrange
                int idade = 16;
                string esperado = "Voto opcional!";

                // Act
                string obtido = Voto.podeVotar(idade);

                // Assert
                Assert.Equal(esperado, obtido);
            }

            [Fact]
            public void TestPodeVotar_Idade18_PodeVotar()
            {
                // Arrange
                int idade = 18;
                string esperado = "Pode votar!";

                // Act
                string obtido = Voto.podeVotar(idade);

                // Assert
                Assert.Equal(esperado, obtido);
            }

            [Fact]
            public void TestPodeVotar_Idade70_VotoOpcional()
            {
                // Arrange
                int idade = 70;
                string esperado = "Voto opcional!";

                // Act
                string obtido = Voto.podeVotar(idade);

                // Assert
                Assert.Equal(esperado, obtido);
            }

            [Fact]
            public void TestPodeVotar_Idade85_VotoOpcional()
            {
                // Arrange
                int idade = 85;
                string esperado = "Voto opcional!";

                // Act
                string obtido = Voto.podeVotar(idade);

                // Assert
                Assert.Equal(esperado, obtido);
            }
        }
    }
}