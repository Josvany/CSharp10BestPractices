namespace carvedrock.bl.principles.Solid.InterfaceSegregation
{
    public class InterfaceSegregation
    {
        public InterfaceSegregation()
        {
            ColdBrewCoffeeMaker ColdCoffeeMachine = new();
            MokaEspressoMaker MokaExpressoMachine = new();

            ColdCoffeeMachine.GetColdCoffee();

            MokaExpressoMachine.GetExpressoCoffee();
        }
    }
}