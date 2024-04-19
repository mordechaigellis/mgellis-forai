import { useEffect, useState } from "react";
import { FieldValues, useForm } from "react-hook-form"
import { fetchColors, postParty } from "./DataUtil";
import { IColor, IParty } from "./DataInterfaces";
interface Props {
    party: IParty
}

export function PartyEdit({ party }: Props) {
    const { register, handleSubmit, reset } = useForm({ defaultValues: party });
    const [colors, setColors] = useState<IColor[]>([]);
    const [errormsg, setErrorMsg] = useState("");

    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchColors();
            setColors(data);
        }
        fetchdata();
    }
        , []);

    useEffect(() => {
        reset(party);
    }, [party, reset]);

    const submitForm = async (data: FieldValues) => {
        //console.log(data);
        const r = await postParty(data);
        setErrorMsg(r.errorMessage)
        reset(r);
    };

    return (
        <div className="bg-light mt-4 p-4">
            <div className="row">
                <div className="col-12">
                    <h2 id="hmsg">{errormsg}</h2>
                </div>
            </div>
            <div className="row">
                <div className="col-12">
                    <form onSubmit={handleSubmit(submitForm)} className="needs-validation">
                        <div className="mb-3">
                            <label htmlFor="partyId" className="form-label">Party ID:</label>
                            <input type="number"  {...register("partyId")} className="form-control" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="partyName" className="form-label">Party Name:</label>
                            <input type="text" {...register("partyName")} className="form-control" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="yearStart" className="form-label">Year Start:</label>
                            <input type="number" {...register("yearStart")} className="form-control" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="colorId" className="form-label">Color ID:</label>
                            <select {...register("colorId")} className="form-select">
                                {colors.map(c => <option key={c.colorId} value={c.colorId}>{c.colorName}</option>)}
                            </select>

                        </div>

                        <div className="mb-3">
                            <label htmlFor="partyDesc" className="form-label">Party Description:</label>
                            <input type="text" {...register("partyDesc")} className="form-control" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="partyColor" className="form-label">Party Color:</label>
                            <input type="text" {...register("partyColor")} className="form-control" />
                        </div>

                        <button type="submit" className="btn btn-primary">Submit</button>
                        <button type="button" id="btndelete" className="btn btn-danger">Delete</button>
                    </form>
                </div>
            </div>
        </div>
    )
}