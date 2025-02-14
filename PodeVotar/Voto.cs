﻿namespace PodeVotar
{
    public static class Voto
    {
        /*
            This method decides, based on a person age, if he or she is allowed to 
            vote in an election:

            + Age between 0 and 15 (including) --> Cannot vote ("Não pode votar!")
            + Age between 16 (including) and 17 (including) --> Optional ("Voto opcional!")
            + Age between 18 (including) and 70 --> Can vote ("Pode votar!")
            + Age 70 or older --> Optional ("Voto opcional!")
        */
        public static string podeVotar(int idade)
        {
            if (idade < 16)
                return "Não pode votar!";

            if ((idade == 16) || (idade == 17) || (idade >= 70))
                return "Voto opcional!";

            if ((idade >= 18) && (idade < 70))
                return "Pode votar!";

            return "Voto opcional!";
        }
    }
}
