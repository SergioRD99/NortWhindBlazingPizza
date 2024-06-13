﻿namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.GetSpecials
{
    internal class GetSpecialsModel (HttpClient client) : IGetSpecialsModels
    {
        private IEnumerable<PizzaSpecialDto> Specials;
        //[
        //    new(1,
        //        "Pizza clÃ¡sica de queso",
        //        89.99m,
        //        "Es de queso y delicioso. Â¿Por quÃ© no querrÃ­as una?",
        //        "cheese.jpg"),
        //    new(2,
        //        "Tocinator",
        //        127.99m,
        //        "Tiene TODO tipo de tocino",
        //        "bacon.jpg"),
        //    new(3,
        //        "ClÃ¡sica de pepperoni",
        //        99.50m,
        //        "Es la pizza con la que creciste, Â¡pero ardientemente deliciosa!",
        //        "pepperoni.jpg"),
        //    new(4,
        //        "Pollo bÃºfalo",
        //        128.75m,
        //        "Pollo picante, salsa picante y queso azul, garantizado que entrarÃ¡s en calor",
        //        "meaty.jpg"),
        //    new(5,
        //        "Amantes del champiÃ±Ã³n",
        //        109.00m,
        //        "Tiene champiÃ±ones. Â¿No es obvio?",
        //        "mushroom.jpg"),
        //    new(6,
        //        "Hawaiana",
        //        90.25m,
        //        "De piÃ±a, jamÃ³n y queso...",
        //        "hawaiian.jpg"),
        //    new(7,
        //        "Delicia vegetariana",
        //        118.50m,
        //        "Es como una ensalada, pero en una pizza",
        //        "salad.jpg"),
        //    new(8,
        //        "Margarita",
        //        89.99m,
        //        "Pizza italiana tradicional con tomates y albahaca",
        //        "margherita.jpg")
        //];

        public async Task<IEnumerable<PizzaSpecialDto>> GetSpecialsAsync()
        {
            if (Specials == null)
            {
                Specials = await client
                    .GetFromJsonAsync<IEnumerable<PizzaSpecialDto>>(
                        Endpoints.GetSpecials);
            }
            return Specials;
        }


        //public async Task<IEnumerable<PizzaSpecialDto>> GetSpecialsAsync() =>
        //    await Task.FromResult(Specials.OrderByDescending(s => s.BasePrice));

    }
}
