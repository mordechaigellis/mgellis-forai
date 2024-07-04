import { useEffect, useState } from "react";
import { fetchDashboard } from "./DataUtil";
import { IDashboard } from "./DataInterfaces";


export default function Home() {
    const [dashboardData, setDashboardData] = useState<IDashboard[]>([]);

    useEffect(() => {

        const fetchData = async () => {
            const response = await fetchDashboard();
            setDashboardData(response);
        };

        fetchData();
    }, []);
    return (
        <>
            <div className="container">
                <h1 className="my-4">Record Keeper</h1>
                <div className="row">
                    <div className="col-3 mb-4">
                        <img className="img img-fluid" src="/images/recordkeeper.jpg" alt="Record Keeper" />
                    </div>
                    {dashboardData.map((item) => (
                        <div key={item.dashboardType} className="col-md-3 col-sm-6 mb-4">
                            <div className="card">
                                <img src={`/images/${item.dashboardType}.jpg`} className="card-img-top" alt={item.dashboardType} />
                                <div className="card-body">
                                    <h5 className="card-title">{item.dashboardType}</h5>
                                    <p className="card-text">{item.dashboardText}</p>
                                </div>
                            </div>
                        </div>
                    ))}
                </div>
            </div>
        </>
    );
}