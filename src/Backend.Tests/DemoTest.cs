using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using MyApp.Backend;
using Xunit;


namespace BackendTests
{
   public class DemoTest
   {
      [Fact]
      public void My()
      {
         Demo c = new Demo();
         bool contains = c.ContainsFive(new List<int> { 1, 3, 5 });
         Assert.True(contains);
      }

      [Fact]
      public void GetText()
      {
         var demoMock = new Mock<IDemo>();
         demoMock.Setup(dm => dm.GetText()).Returns("Test");

         string text = demoMock.Object.GetText();
         Assert.Equal("Test", text);
      }

      [Fact]
      public void PassingTest()
      {
         Assert.Equal(4, Add(2, 2));
      }

      [Fact]
      public void FailingTest()
      {
         Assert.Equal(5, Add(2, 2));
      }

      int Add(int x, int y)
      {
         return x + y;
      }
   }
}
