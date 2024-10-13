import { Project } from "./Project";
import { Technologie } from "./Technologie";
export interface TechnologieProject {
    Id: number;
    TechnologieId: number;
    ProjectId: number;
    Project?: Project;
    Technologie?: Technologie;
}