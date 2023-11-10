using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/// 2129107
/// Simon Lacaille
namespace GestElection
{
    //Attributs privés 
    private string nom_election;
    private DateTime date_election;
    // Propriétés
    public string Nom_election
    {
        get { return this.nom_election; }
        set { if (value != "") this.nom_election = value; }
    }
    public string 
    {
        get { return this.prenom; }
        set { if (verifier_regex(value) == true) this.prenom = value; }
    }

    public DateTime Date_election
    {
        get { return this.date_election; }
        set { if (verifier_date(value)) this.date_election = value; }
}
    //Le constructeur 
    /// <summary>
    /// Instancie un objet de la classe Personne
    /// </summary>
    /// <param name="p_nom_election">Nom de l'élection</param>
    /// <param name="p_date_election">Date de l'élection</param>
    public Personne(string p_nom_election = "!", DateTime p_date_election = default(DateTime))
    {
        this.nom_election = p_nom_election;
        this.date_ekection = p_date_election;
    }

    //Méthodes
    /// <summary>
    /// </summary>
    /// <param name="date_election">Date de l'élection</param>
    /// <returns> Retourne true si la date est supérior à celle d'aujourd'hui  et false sinon </returns>
    private bool verifier_date(DateTime date_election)
    {
        if (date_elec<dateTime.Now) return true;
        else return false;

    }

    //Méthodes
    /// <summary>
    /// Montrer les membres retrouvé dans une circonsription
    /// </summary>
    /// <returns>membres dans une circonsription</returns>
    public static int Statiques_circonsription()
    {
        return listelecteur.value;
    }
}
