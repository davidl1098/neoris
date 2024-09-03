using ClientePersonaService.Models;
using NUnit.Framework;

namespace Services.Tests
{
    [TestFixture]
    public class ClienteTests
    {
        // Pruebas de Creaci�n de Clientes basadas en los Casos de Uso

        [Test]
        public void Cliente_Creation_ShouldSetPropertiesCorrectly_ForJoseLema()
        {
            // Arrange
            var cliente = new Cliente
            {
                Id = 1,
                Nombre = "Jose Lema",
                Direccion = "Otavalo sn y principal",
                Telefono = "098254785",
                Contrasena = "1234",
                Estado = true
            };

            // Assert
            Assert.AreEqual(1, cliente.Id);
            Assert.AreEqual("Jose Lema", cliente.Nombre);
            Assert.AreEqual("Otavalo sn y principal", cliente.Direccion);
            Assert.AreEqual("098254785", cliente.Telefono);
            Assert.AreEqual("1234", cliente.Contrasena);
            Assert.IsTrue(cliente.Estado);
        }

        [Test]
        public void Cliente_Creation_ShouldSetPropertiesCorrectly_ForMarianelaMontalvo()
        {
            // Arrange
            var cliente = new Cliente
            {
                Id = 2,
                Nombre = "Marianela Montalvo",
                Direccion = "Amazonas y NNUU",
                Telefono = "097548965",
                Contrasena = "5678",
                Estado = true
            };

            // Assert
            Assert.AreEqual(2, cliente.Id);
            Assert.AreEqual("Marianela Montalvo", cliente.Nombre);
            Assert.AreEqual("Amazonas y NNUU", cliente.Direccion);
            Assert.AreEqual("097548965", cliente.Telefono);
            Assert.AreEqual("5678", cliente.Contrasena);
            Assert.IsTrue(cliente.Estado);
        }

        [Test]
        public void Cliente_Creation_ShouldSetPropertiesCorrectly_ForJuanOsorio()
        {
            // Arrange
            var cliente = new Cliente
            {
                Id = 3,
                Nombre = "Juan Osorio",
                Direccion = "13 junio y Equinoccial",
                Telefono = "098874587",
                Contrasena = "1245",
                Estado = true
            };

            // Assert
            Assert.AreEqual(3, cliente.Id);
            Assert.AreEqual("Juan Osorio", cliente.Nombre);
            Assert.AreEqual("13 junio y Equinoccial", cliente.Direccion);
            Assert.AreEqual("098874587", cliente.Telefono);
            Assert.AreEqual("1245", cliente.Contrasena);
            Assert.IsTrue(cliente.Estado);
        }

        // Pruebas de Validaci�n de Contrase�a

        [Test]
        public void EsContrasenaValida_ShouldReturnTrue_ForValidNumericContrasena()
        {
            // Arrange
            var cliente = new Cliente
            {
                Contrasena = "1234"  // Contrase�a v�lida de 4 d�gitos num�ricos
            };

            // Act
            var result = cliente.EsContrasenaValida();

            // Assert
            Assert.IsTrue(result);  // La contrase�a v�lida deber�a devolver true
        }

        [Test]
        public void EsContrasenaValida_ShouldReturnFalse_ForInvalidContrasena()
        {
            // Arrange
            var cliente = new Cliente
            {
                Contrasena = "12"  // Contrase�a demasiado corta
            };

            // Act
            var result = cliente.EsContrasenaValida();

            // Assert
            Assert.IsFalse(result);  // La contrase�a no v�lida deber�a devolver false
        }

        [Test]
        public void EsContrasenaValida_ShouldReturnFalse_ForNullContrasena()
        {
            // Arrange
            var cliente = new Cliente
            {
                Contrasena = null  // Contrase�a nula
            };

            // Act
            var result = cliente.EsContrasenaValida();

            // Assert
            Assert.IsFalse(result);  // La contrase�a nula deber�a devolver false
        }
    }
}
