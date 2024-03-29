﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace BlazorEcommerce.Server.Controllers
{



    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id=1,
            Title="The Hitchhiker's Guide to the Galaxy",
            Description="The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film",
            ImageUrl="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
            Price = 9.99m
        },
        new Product
        {
            Id=2,
            Title="Ready Player One",
            Description="Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune",
            ImageUrl="https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
            Price = 7.99m
        },
        new Product
        {
            Id=3,
            Title="Nineteen Eighty-Four",
            Description="Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society",
            ImageUrl="https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
            Price = 6.99m
        }

    };

        [HttpGet]

        public async Task<IActionResult> GetProduct()
        {
            return Ok(Products);
        }

    }
}
