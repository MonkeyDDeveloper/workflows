import { ProfessionalExperience } from "./ProfessionalExperience";
import { Technologie } from "./Technologie";
export interface TechnologieExperience {
    Id: number;
    TechnologieId: number;
    ExperienceId: number;
    ProfessionalExperience?: ProfessionalExperience;
    Technologie?: Technologie;
}