import { ProfessionalExperience } from "@/models/ProfessionalExperience";
import { FaDocker } from "react-icons/fa";
import { Card, CardHeader, CardBody, Image } from "@nextui-org/react";

export default function ExperienceCard({ experience }: { experience: ProfessionalExperience }) {
    return (
        <Card className="py-4">
            <CardHeader className="pb-0 pt-2 px-4 flex-col items-start">
                <h4 className="text-large uppercase font-bold mb-1 font-minecraft">{experience.title}</h4>
                <small className="text-default-500">{experience.description}</small>
                <p className="font-bold text-tiny">{experience.startDate} - {experience.endDate}</p>
            </CardHeader>
            <CardBody className="overflow-visible py-2">
                <Image
                    alt="Card background"
                    className="object-cover rounded-xl w-full"
                    src="https://nextui.org/images/hero-card-complete.jpeg"
                    width={270}
                />
            </CardBody>
        </Card>
    );
}