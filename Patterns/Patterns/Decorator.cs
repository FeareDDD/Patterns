using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns
{
    class Decorator : Phone
    {
        protected Phone DecoratedPhone { get; set; }
        public Decorator(Phone decorator)
        {
            DecoratedPhone = decorator;
        }
        public override void IsPhoneCasePresented()
        {
            DecoratedPhone.IsPhoneCasePresented();
        }
    }

    class Phone
    {
        protected string Brand { get; set; }
        public virtual void IsPhoneCasePresented()
        {
            Console.WriteLine("There is no phone case.");
        }
    }

    class Sony: Phone
    {
        public Sony()
        {
            Brand = "Sony";
        }
    }

    class PhoneCase : Decorator
    {
        public PhoneCase(Phone decoratedPhone):base(decoratedPhone)
        {

        }

        public override void IsPhoneCasePresented()
        {
            base.IsPhoneCasePresented();
            Console.WriteLine("Now your phone have phone case.");
        }
    }
}
