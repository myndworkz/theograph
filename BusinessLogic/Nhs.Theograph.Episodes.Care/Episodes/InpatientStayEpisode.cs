﻿namespace Nhs.Theograph.Care.Episodes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Nhs.Theograph.Core.Episode;
    using Nhs.Theograph.Care.ClinicalEvents;

    public class InpatientStayEpisode : EpisodeDetailsBase
    {
        public override EpisodeType EpisodeType
        {
            get { return new EpisodeType { Value = "Inpatient Stay" }; }
            set { throw new NotImplementedException(); }
        }

        public IList<DiagnosisEvent> Diagnosis { get; set; }
        public IList<TreatmentEvent> Treatment { get; set; }
        public IList<InvestigationEvent> Investigation { get; set; }
    }
}
