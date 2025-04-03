import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-research',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './research.component.html',
  styleUrls: ['./research.component.scss']
})
export class ResearchComponent {
  pageTitle = 'Research & Projects';
  
onImageLoadError(event: any) {
  event.target.src = 'images/default-project.jpg';
}

researchProjects = [
  {
    title: 'Distributed Hydrological Modeling and Model Intercomparison',
    description: 'Advancing spatially distributed hydrological modeling techniques through comprehensive model development, calibration, and intercomparison. Focusing on improving streamflow predictions in gaged and ungaged basins using advanced parameter estimation methods.',
    technologies: ['WetSpa', 'SWAT', 'FORTRAN', 'ArcGIS', 'PEST', 'GIS Modeling', 'Statistical Analysis'],
    period: '2006 - 2009',
    image: 'images/hydro-model.jpg'
  },
  {
    title: 'Hydrological Model Uncertainty Quantification',
    description: 'Developing advanced statistical techniques to quantify and reduce uncertainty in hydrological models. Implementing innovative methods like Box-Cox transformations and time series analysis to improve model parameter estimation and prediction confidence.',
    technologies: ['PEST', 'FORTRAN', 'R', 'ArcView', 'Statistical Inference', 'Uncertainty Analysis'],
    period: '2009 - 2012',
    image: 'images/uncertainty-analysis.jpg'
  },
  {
    title: 'Remote Sensing Integration in Hydrological Modeling',
    description: 'Integrating advanced remote sensing and radar-based precipitation data into distributed hydrological models. Exploring methodologies to improve model performance in data-scarce regions using satellite and radar datasets.',
    technologies: ['NEXRAD', 'GRACE', 'ArcGIS', 'MATLAB', 'FORTRAN', 'Geospatial Analysis'],
    period: '2009 - 2012',
    image: 'images/remote-sensing.jpg'
  },
  {
    title: 'Hydrological Data Analysis and Modeling',
    description: 'Developing comprehensive approaches for environmental data analysis, parameter optimization, and advanced hydrological modeling techniques to support water resources management and research.',
    technologies: ['PEST', 'ArcView', 'FORTRAN', 'GIS', 'Statistical Modeling', 'Hydrological Software'],
    period: '2012 - 2015',
    image: 'images/data-analysis.jpg'
  },
  {
    title: 'Numerical Model Optimization and Uncertainty Quantification',
    description: 'Developing methodologies to optimize numerical models and quantify uncertainty in predictions, particularly in data-scarce regions.',
    technologies: ['WetSpa','Advanced Parameter Estimation','Environmental Modeling','Model Calibration',' Uncertainty Analysis','FORTRAN','Data Analysis'],
    period: 'Feb 2018 - Sep 2018',
    image: 'images/wetspa.jpg'
  }
];
  
 fundingScholarships = [
   {
     title: 'WetSpa Hydrological Model Development',
     organization: 'Vlaamse Milieumaatschappij (VMM)',
     period: 'Feb 2018 - Sep 2018',
     amount: '€6,000',
     description: 'Contract for developing WetSpa hydrological model program to improve river flow modeling in Flanders, Belgium.',
     type: 'Contract',
     source: 'Alireza Safari'
   },
   {
     title: 'WetSpa Model Streamflow Prediction Research',
     organization: 'Vrije Universiteit Brussel',
     period: '2012 - 2013',
     amount: '€8,000',
     description: 'Grant to improve WetSpa model for predicting streamflows in gaged and ungaged catchments. Focus on enhancing model performance through baseflow recession coefficient estimation.',
     type: 'Grant',
     source: 'Alireza Safari'
   },
   {
     title: 'PhD Scholarship',
     organization: 'Iranian Ministry of Science, Research and Technology',
     period: 'Sep 2005 - Dec 2009',
     amount: '€50,000',
     description: 'Full scholarship to pursue doctoral studies abroad.',
     type: 'Award',
     source: 'Alireza Safari'
   }
 ];
}
