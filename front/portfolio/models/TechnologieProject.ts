import { Project } from "./Project";
import { Technologie } from "./Technologie";
export interface TechnologieProject {
    id: number;
    technologieId: number;
    projectId: number;
    project?: Project;
    technologie?: Technologie;
}