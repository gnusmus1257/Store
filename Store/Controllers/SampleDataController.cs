using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.models;
using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static IEnumerable<Product> Products = new List<Product> {
            new Product {
                Name = "MacBook  air", Category = new Category{ Name = "Laptops"},
                Description = "Это самый любимый Mac, в который можно заново влюбиться. Новый MacBook Air — ещё более тонкий и лёгкий, оснащён дисплеем Retina, Touch ID, клавиатурой нового поколения, трекпадом Force Touch. И представлен в трёх цветах — серебристом, золотом и «серый космос». Это самый экологичный Mac. Сохранив его культовый дизайн, мы использовали для корпуса только переработанный алюминий.1 И это невероятно удобный MacBook Air — он работает весь день без подзарядки и может справиться с любыми задачами.",
                Price = 1200, ShortDescription = "Это самый любимый Mac, в который можно заново влюбиться. Новый MacBook Air — ещё более тонкий и лёгкий, оснащён дисплеем Retina, Touch ID, клавиатурой нового поколения, трекпадом Force Touch. И представлен в трёх цветах — серебристом, золотом и «серый космос». Это самый экологичный Mac. Сохранив его культовый дизайн, мы использовали для корпуса только переработанный алюминий.1 И это невероятно удобный MacBook Air — он работает весь день без подзарядки и может справиться с любыми задачами.",
                Specifications = new List<Specification> {new Specification() {
                    Name = "Display",
                        Value = "Дисплей с диагональю 13,3 дюйма, подсветкой LED и технологией IPS; разрешение 2560×1600 пикселей (227 пикселей/дюйм) обеспечивает высокое качество цветопередачи (миллионы цветов)",
                    },
                    new Specification {
                        Name = "Touch ID",
                        Value = "Встроенный датчик Touch ID"
                    }}
            },
            new Product {
                Name = "MacBook  PRO", Category = new Category{ Name = "Laptops"},
                Description = "Это самый можщный Mac, в который можно заново влюбиться. Новый MacBook Air — ещё более тонкий и лёгкий, оснащён дисплеем Retina, Touch ID, клавиатурой нового поколения, трекпадом Force Touch. И представлен в трёх цветах — серебристом, золотом и «серый космос». Это самый экологичный Mac. Сохранив его культовый дизайн, мы использовали для корпуса только переработанный алюминий.1 И это невероятно удобный MacBook Air — он работает весь день без подзарядки и может справиться с любыми задачами.",
                Price = 1800, ShortDescription = "Это самый любимый Mac, в который можно заново влюбиться. Новый MacBook Air — ещё более тонкий и лёгкий, оснащён дисплеем Retina, Touch ID, клавиатурой нового поколения, трекпадом Force Touch. И представлен в трёх цветах — серебристом, золотом и «серый космос». Это самый экологичный Mac. Сохранив его культовый дизайн, мы использовали для корпуса только переработанный алюминий.1 И это невероятно удобный MacBook Air — он работает весь день без подзарядки и может справиться с любыми задачами.",
                Specifications = new List<Specification> {new Specification() {
                    Name = "Display",
                        Value = "Дисплей с диагональю 15,6 дюйма, подсветкой LED и технологией IPS; разрешение 2560×1600 пикселей (227 пикселей/дюйм) обеспечивает высокое качество цветопередачи (миллионы цветов)",
                    },
                    new Specification {
                        Name = "Touch ID",
                        Value = "Встроенный датчик Touch ID"
                    }}
            }
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpGet("[action]")]
        public IEnumerable<Product> GetSamplesOfProducts()
        {
            return Products;
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
