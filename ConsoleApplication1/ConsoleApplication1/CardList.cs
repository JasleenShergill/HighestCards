using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Jasleen
 * Date: July 27, 2017
 * Description: Lesson 11
 * Version: 0.4  new Deck class
 */

namespace ConsoleApplication1
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS
        public CardList()
        {
            this._initialize();
        }

        // PRIVATE METHODS
        protected abstract void _initialize();

        // PUBLIC METHODS
    }
}