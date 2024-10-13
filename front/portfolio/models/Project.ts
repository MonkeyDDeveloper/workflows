import { TechnologieProject } from "./TechnologieProject"
import { ProjectTask } from "./ProjectTask"
export interface Project {
    id: number,
    name: string,
    description: string,
    projectTasks?: ProjectTask[]
    projectTechnologies?: TechnologieProject[]
}