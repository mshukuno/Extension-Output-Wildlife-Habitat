//  Copyright 2005-2010 Portland State University, University of Wisconsin-Madison
//  Authors:  Robert M. Scheller, Jimm Domingo

using Landis.Utilities;
using System.Collections.Generic;

namespace Landis.Extension.Output.WildlifeHabitat
{
    /// <summary>
    /// The parameters for the plug-in.
    /// </summary>
    public class SuitabilityParameters
        : ISuitabilityParameters
    {
        private string wildlifeName;
        private string suitabilityType;
        private string disturbanceType;
        private double[] coefficients;
        private List<IMapDefinition> forestTypes;
        private Dictionary<int,double> fireSeverities;
        private Dictionary<string, double> harvestPrescriptions;
        private Dictionary<string,Dictionary<int,double>> suitabilities;
      
        //---------------------------------------------------------------------

        public string WildlifeName
        {
            get
            {
                return wildlifeName;
            }
            set
            {
                wildlifeName = value;
            }
        }

        //---------------------------------------------------------------------
        public string SuitabilityType
        {
            get
            {
                return suitabilityType;
            }
            set
            {
                suitabilityType = value;
            }
        }

        //---------------------------------------------------------------------
        public string DisturbanceType
        {
            get
            {
                return disturbanceType;
            }
            set
            {
                disturbanceType = value;
            }
        }

        //---------------------------------------------------------------------
        /// <summary>
		/// Reclass coefficients for species
		/// </summary>
		public double[] ReclassCoefficients
		{
			get {
				return coefficients;
			}
		}

		//---------------------------------------------------------------------

		/// <summary>
		/// Reclass maps
		/// </summary>
        public List<IMapDefinition> ForestTypes
		{
			get {
				return forestTypes;
			}
		}

        //---------------------------------------------------------------------
        public Dictionary<int, double> FireSeverities
        {
            get
            {
                return fireSeverities;
            }
            set
            {
                fireSeverities = value;
            }
        }
        //---------------------------------------------------------------------
        public Dictionary<string, double> HarvestPrescriptions
        {
            get
            {
                return harvestPrescriptions;
            }
            set
            {
                harvestPrescriptions = value;
            }
        }
        //---------------------------------------------------------------------
        // Dictionary with key equal to row names and
        // values equal to a dictionary with key equal to column headings and
        // values equal to suitability values
        public Dictionary<string,Dictionary<int, double>> Suitabilities
        {
            get
            {
                return suitabilities;
            }
            set
            {
                suitabilities = value;
            }
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public SuitabilityParameters(int speciesCount)
        {
            wildlifeName = "wildlifeName";
            coefficients = new double[speciesCount];
            forestTypes = new List<IMapDefinition>();
            fireSeverities = new Dictionary<int, double>();
            harvestPrescriptions = new Dictionary<string, double>();
            suitabilities = new Dictionary<string,Dictionary<int,double>>();
            disturbanceType = "None";
        }

    }
}
