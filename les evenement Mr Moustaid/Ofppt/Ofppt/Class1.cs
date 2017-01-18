using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofppt
{
    class LesDos
    {
        List<Dossier> LesDossier = new List<Dossier>();
        int index = -1;
        public LesDos() 
    
    {
    }

    //==========================================================================================//


    //==========================================================================================//
    public Dossier this[int i]
    {
        get { return LesDossier[i]; }
        set { LesDossier[i] = value; }
       
    }
    //==========================================================================================//

    public int nombreD { get { return LesDossier.Count; } }

    //==========================================================================================//

    public int Index { get { return index; } }

    //==========================================================================================//

    public void ajouterDO(Dossier Dos)
    {
     
            LesDossier.Add(Dos);

            index = LesDossier.Count - 1;
    }
 

    //==========================================================================================//

    public Dossier Dosrecent()
    {
        if (LesDossier.Count > 0 && index > 0)
        {
            return LesDossier[index];
        }
        else return null;

    }

 

    //==========================================================================================//

    public void Supprimer()
    {
        if (LesDossier.Count > 0)
            LesDossier.RemoveAt(index);
        if (index == LesDossier.Count) index--;
    }

    //==========================================================================================//

    public Dossier Suivant()
    {
        if (index < LesDossier.Count - 1)
        {
            index++;
            return LesDossier[index];
        }
        else return LesDossier[index];
    }

    //==========================================================================================//

    public Dossier Precedent()
    {
        if ( index >0)
        {
            index--;
            return LesDossier[index];
        }
        else return LesDossier[index];
    }

    //==========================================================================================//

    public Dossier Premier()
    {
       
            index=0;
            return LesDossier[index];
    
    }

    //==========================================================================================//

    public Dossier Dernier()
    {

        index = LesDossier.Count - 1;
        return LesDossier[index];

    }

    //==========================================================================================//

    public int RechercherSiNUMDOssDejaExist(int num)
    { int res=-1;
   for(int i=0;i<LesDossier.Count;i++)
        {
            if (LesDossier[i]. NumDossier == num)
            {   res=i;break;}
            
        }
        
        return res;
    }
    public int RechercherSiCNEDOssDejaExist(int cne)
    {
        int res = -1;
        for (int i = 0; i < LesDossier.Count; i++)
        {
            if (LesDossier[i].Cne == cne)
            { res = i; break; }

        }

        return res;
    }

    //==========================================================================================//

    public int RechercherSiPreNomDejaExist(string Prenom)
    {
        int res = -1;
        for(int i=0;i<LesDossier.Count;i++)
        {
            if (LesDossier[i]. Prénom == Prenom)
            { res = i; break; }

        }

        return res;
    }

    //==========================================================================================//

    public int RechercherSiNomDejaExist(string nom)
    {
        int res = -1;
        for (int i = 0; i < LesDossier.Count; i++)
        {
            if (LesDossier[i].Nom == nom)
            { res = i; break; }

        }

        return res;
    }

    //==========================================================================================//

    }
}
