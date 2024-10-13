import { ProfessionalExperience } from "./ProfessionalExperience";
import { Technologie } from "./Technologie";
export interface TechnologieExperience {
    id: number;
    technologieId: number;
    experienceId: number;
    professionalExperience?: ProfessionalExperience;
    technologie?: Technologie;
}