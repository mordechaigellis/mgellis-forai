import { useEffect, useState } from "react";
import { FieldValues, useForm } from "react-hook-form";
import { blankPresident, deletePresident, fetchParties, postPresident } from "./DataUtil";
import { IParty, IPresident } from "./DataInterfaces";
import { ToastContainer, toast } from "react-toastify";
import 'react-toastify/dist/ReactToastify.css';



interface Props {
    president: IPresident;
    onCancel: () => void;
    onPresidentUpdate: (prez: IPresident) => void;
    onPresidentDelete: (deletedpresidentid: number) => void;
}

export function PresidentEdit({ president, onCancel, onPresidentUpdate, onPresidentDelete }: Props) {
    const { register, handleSubmit, reset } = useForm({
        defaultValues: president
    });
    const [parties, setParties] = useState<IParty[]>([]);
    const [errormsg, setErrorMsg] = useState("");

    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchParties();
            setParties(data);
            reset(president);
        };
        fetchdata();
    }, []);

    useEffect(() => {
        reset(president);
    }, [president, reset]);

    const submitForm = async (data: FieldValues) => {
        const transformedData = {
            ...data,
            dateDied: data.dateDied === "" ? null : data.dateDied
        };
        try {
            setErrorMsg("");
            const r = await postPresident(transformedData);
            setErrorMsg(r.errorMessage);
            if (!r.errorMessage) {
                onPresidentUpdate(r);
                toast.success("President saved successfully!");
            }
            reset(r);
        }
        catch (error: unknown) {
            if (error instanceof Error) {
                setErrorMsg(error.message);
            } else {
                setErrorMsg("An error occurred");
            }
        }
    };

    const handleDelete = async () => {
        try {
            setErrorMsg("");
            const r = await deletePresident(president.presidentId);
            setErrorMsg(r.errorMessage);
            if (r.errorMessage === "") {
                onPresidentDelete(president.presidentId);
                reset(blankPresident);
                toast.success("President deleted successfully!");
            }
        } catch (error: unknown) {
            if (error instanceof Error) {
                setErrorMsg(error.message);
            } else {
                setErrorMsg("An error occurred");
            }
        }
    };

    return (
        <div className="bg-light mt-4 p-4">
            <ToastContainer />
            <div className="row">
                <div className="col-12">
                    <h2 id="hmsg">{errormsg}</h2>
                </div>
            </div>
            <div className="row">
                <div className="col-12">
                    <form onSubmit={handleSubmit(submitForm)} className="needs-validation">
                        <div className="mb-3 row">
                            <div className="col-6">
                                <div className="col-sm-6">
                                    <label htmlFor="num" className="col-form-label">Num</label>
                                    <input type="number" {...register("num", { valueAsNumber: true })} className="form-control" />
                                </div>
                            </div>
                            <div className="col-6">
                                <label htmlFor="partyId" className="col-sm-2 col-form-label">Party</label>
                                <div className="col-sm-10">
                                    <select {...register("partyId", { valueAsNumber: true })} className="form-select">
                                        <option value="0"></option>
                                        {parties.map(p => <option key={p.partyId} value={p.partyId}>{p.partyName}</option>)}
                                    </select>
                                </div>
                            </div>
                        </div>

                        <div className="mb-3 row">
                            <div className="col-sm-6">
                                <label htmlFor="firstName" className="col-form-label">First Name</label>
                                <input type="text" {...register("firstName")} className="form-control" required />
                            </div>
                            <div className="col-sm-6">
                                <label htmlFor="lastName" className="col-form-label">Last Name</label>
                                <input type="text" {...register("lastName")} className="form-control" required />
                            </div>
                        </div>

                        <div className="mb-3 row">
                            <div className="col-sm-6">
                                <label htmlFor="dateBorn" className="col-form-label">Date Born</label>
                                <input type="date" {...register("dateBorn")} className="form-control" required />
                            </div>
                            <div className="col-sm-6">
                                <label htmlFor="dateDied" className="col-form-label">Date Died</label>
                                <input type="date" {...register("dateDied")} className="form-control" />
                            </div>
                        </div>

                        <div className="mb-3 row">
                            <div className="col-sm-6">
                                <label htmlFor="termStart" className="col-form-label">Term Start</label>
                                <input type="number" {...register("termStart", { valueAsNumber: true })} className="form-control" />
                            </div>
                            <div className="col-sm-6">
                                <label htmlFor="termEnd" className="col-form-label">Term End</label>
                                <input type="number" {...register("termEnd", { valueAsNumber: true })} className="form-control" />
                            </div>
                        </div>

                        <div className="mb-3 row">
                            <div className="col-12 text-center">
                                <button type="submit" className="btn btn-primary me-2">Save</button>
                                <button onClick={handleDelete} type="button" id="btndelete" className="btn btn-danger me-2">Delete</button>
                                <button onClick={onCancel} type="button" id="btncancel" className="btn btn-warning">Cancel</button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
            <hr />
            <ul className="nav nav-tabs" id="myTab" role="tablist">
                <li className="nav-item" role="presentation">
                    <button className="nav-link active" id="executive-orders-tab" data-bs-toggle="tab" data-bs-target="#executive-orders" type="button" role="tab" aria-controls="executive-orders" aria-selected="true">Executive Orders</button>
                </li>
                <li className="nav-item" role="presentation">
                    <button className="nav-link" id="medals-tab" data-bs-toggle="tab" data-bs-target="#medals" type="button" role="tab" aria-controls="medals" aria-selected="false">Medals</button>
                </li>
            </ul>

            <div className="tab-pane fade show active" id="executive-orders" role="tabpanel" aria-labelledby="executive-orders-tab">
                <div className="row">
                    {/* <ExecutiveOrderGrid
                            president={president}
                            onChanged={handleExecutiveOrderChange}
                        /> */}
                </div>
            </div>
            <div className="tab-pane fade" id="medals" role="tabpanel" aria-labelledby="medals-tab">
                <div className="row">
                    {/* <PresidentMedalGrid
                            president={president}
                            onChanged={handlePresidentMedalChange}
                        /> */}
                </div>
            </div>

        </div>
    );
}
