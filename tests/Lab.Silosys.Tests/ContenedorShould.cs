using System;
using Lab.Silosys.Services;
using Xunit;
using Moq;

namespace Lab.Silosys.Tests
{
    public class ContenedorShould
    {
        /// <summary>
        /// Behavior Verification
        /// </summary>
        //[Fact]
        //public void DecreaseCapacity()
        //{
        //    // Arrange
        //    Mock<IExternalServiceExample> mockService = new Mock<IExternalServiceExample>();
        //    mockService.Setup(x => x.CreateAlert(It.IsAny<AlertRequest>())).Returns(new AlertResponse
        //    {
        //        AlertStatus = AlertStatus.Error
        //    });

        //    Contenedor sut = new Contenedor(mockService.Object, 1000);

        //    // Act
        //    sut.Fill(1);

        //    // Assert
        //    mockService.Verify(m => m.CreateAlert(null), Times.Never);
        //}

        [Fact]
        public void DecreaseCapacity()
        {
            // Arrange
            Contenedor sut = new Contenedor(1000);

            // Act
            sut.Fill(1);

            // Assert
            Assert.Equal(999M, sut.AvailableCapacity);
        }

        //[Theory]
        //[InlineData(1000, 1, 999)]
        //[InlineData(1000, 0, 1000)]
        //[InlineData(100, 99, 1)]
        //public void DecreaseCapacity(decimal capacity, decimal quantity, decimal available)
        //{
        //    // Arrange
        //    Contenedor sut = new Contenedor(capacity);

        //    // Act
        //    sut.Fill(quantity);

        //    // Assert
        //    Assert.Equal(available, sut.AvailableCapacity);
        //}

        //[Fact]
        //public void AvoidUseNegativeQuantities()
        //{
        //    // Arrange
        //    const decimal capacity = 1000;
        //    const decimal quantity = -1M;
        //    Contenedor sut = new Contenedor(capacity);

        //    // Act
        //    ArgumentOutOfRangeException ex = Assert.Throws<ArgumentOutOfRangeException>(() => sut.Fill(quantity));

        //    // Assert
        //    Assert.Equal("quantity", ex.ParamName);
        //}

        //[Fact]
        //public void AvoidExceedCapacity()
        //{
        //    // Arrange
        //    const decimal capacity = 1000;
        //    const decimal quantity = 1001;
        //    Contenedor sut = new Contenedor(capacity);

        //    // Act
        //    ArgumentOutOfRangeException ex =
        //        Assert.Throws<ArgumentOutOfRangeException>(() => sut.Fill(quantity));

        //    // Assert
        //    Assert.Equal("quantity", ex.ParamName);
        //}

        //[Fact]
        //public void NotifyWhenIsAlmostFull()
        //{
        //    const decimal capacity = 1000;
        //    const decimal quantity = 900;
        //    Contenedor sut = new Contenedor(capacity);

        //    Assert.Raises<EventArgs>(
        //        handler => sut.WarningEventHandler += handler,
        //        handler => sut.WarningEventHandler -= handler,
        //        () => sut.Fill(quantity)
        //    );
        //}
    }
}
