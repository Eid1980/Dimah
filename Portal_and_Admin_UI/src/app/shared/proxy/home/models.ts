
export interface DimahProjectsListDto {
  id: string;
  projectName: string;
  projectTypeImageName: string;
}

export interface ProjectDetailsDto {
  id: string;
  charityId: string;
  name: string;
  description: string;
  projectCost: number;
  projectLocation: string;
  image: string;
  relatedProjects: DimahProjectsListDto[];
}

