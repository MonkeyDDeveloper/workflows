import { TechnologieProject } from "./TechnologieProject"
import { ProjectTask } from "./ProjectTask"
export interface Project {
    Id: number,
    Name: string,
    Description: string,
    ProjectTasks?: ProjectTask[]
    ProjectTechnologies?: TechnologieProject[]
}