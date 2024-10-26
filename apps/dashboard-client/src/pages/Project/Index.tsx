// src/pages/Project/Index.tsx
import { useState } from "react";
import Wrapper from "../../layout/Wrapper/Wrapper";
import { Button, Toolbar } from "@fluentui/react-components";
import { useNavigate } from "react-router-dom";
import dashboardServices from "../../api/dashboardServices";

const ProjectHome: React.FC = () => {
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState<string | null>(null);
    const [projects, setProjects] = useState([]);
    const navigate = useNavigate();
    const headerBlock = (
        <header className="w-full text-center text-gray-200  bg-gray-700">
            <h1 className="text-3xl font-bold">Projects</h1>
        </header>
    );

    const fetchProjects = async () => {
        setLoading(true);
        try {
            const response = await dashboardServices.fetchEntities("project");
            setProjects(response.data);
        } catch (error: any) {
            setError(error.message);
        } finally {
            setLoading(false);
        }
    }


    return (
        <Wrapper header={headerBlock}>
            {
                loading
                    ? <p>Loading...</p>
                    : error
                        ? <p>{error}</p>
                        : projects.map((project: any) => (
                            <div key={project.id}>
                                <h1>{project.name}</h1>
                                <p>{project.description}</p>
                            </div>
                        ))
            }

            {/* add project crud toolbar */}
            <Toolbar aria-label="Project Toolbar">
                <Button appearance="primary" onClick={() => navigate("/projects/add")}>Add Project</Button>

            </Toolbar>

        </Wrapper>
    )
}

export default ProjectHome;