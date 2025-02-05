import { useState, useRef, useEffect } from "react";
import { AgGridReact } from "ag-grid-react";
import "ag-grid-community/styles/ag-grid.css";
import "ag-grid-community/styles/ag-theme-alpine.css";
import { ColDef, ICellRendererParams } from "ag-grid-community";
import { IMedal, IPresident, IPresidentMedal } from "./DataInterfaces";
import { fetchMedals, postPresidentMedal, deletePresidentMedal, blankPresidentMedal } from "./DataUtil";
import ActionCellRenderer from "./ActionCellRenderer";
import { handleAddNew } from "./HandleAddNew";

interface Props {
    president: IPresident;
    onChanged: (value: IPresidentMedal, fordelete: boolean) => void;
}

export default function PresidentMedalGrid({ president, onChanged }: Props) {
    const [rowData, setRowData] = useState<IPresidentMedal[]>(president?.presidentMedalList || []);
    const [medals, setMedals] = useState<IMedal[]>([]);
    const [errormsg, setErrormsg] = useState("");
    const gridRef = useRef<any>(null);

    useEffect(() => {
        const fetchData = async () => {
            const data = await fetchMedals();
            setMedals(data);
        };
        fetchData();
    }, []);

    const defaultColDef: ColDef = {
        flex: 1,
        minWidth: 100,
        editable: true,
    };

    const colDefs: ColDef<IPresidentMedal>[] = [
        {
            field: "medalName",
            editable: true,
            cellEditor: "agSelectCellEditor",
            cellEditorParams: {
                values: medals.map(medal => medal.medalName),
            },
            valueGetter: (params) => {
                const data = params.data as IPresidentMedal;
                const medal = medals.find(m => m.medalId === data.medalId);
                return medal ? medal.medalName : data.medalName;
            },
            valueSetter: (params) => {
                const data = params.data as IPresidentMedal;
                const selectedMedal = medals.find(medal => medal.medalName === params.newValue);
                if (selectedMedal) {
                    data.medalId = selectedMedal.medalId;
                    data.medalName = selectedMedal.medalName;
                    return true;
                }
                return false;
            },
        },
        {
            headerName: "Actions",
            cellRenderer: (params: ICellRendererParams) => (
                <ActionCellRenderer<IPresidentMedal>
                    params={params}
                    onChanged={onChanged}
                    setError={setErrormsg}
                    updateObject={postPresidentMedal}
                    deleteObject={deletePresidentMedal}
                    rowData={rowData}
                    gridRef={gridRef}
                    setRowData={setRowData}
                    idKey="presidentMedalId"
                />
            ),
            editable: false,
            filter: false,
        },
    ];


    return (
        <>
            <div className="row">
                <div className="col-2">
                    <button
                        className="btn btn-primary"
                        onClick={() => handleAddNew(
                            blankPresidentMedal,
                            {},
                            "presidentMedalId",
                            "presidentId",
                            president.presidentId,
                            rowData,
                            setRowData,
                            gridRef
                        )}
                    >
                        Add New
                    </button>
                </div>
            </div>
            <div className={"ag-theme-alpine"} style={{ width: "50%", height: "250px" }}>
                <AgGridReact
                    ref={gridRef}
                    rowData={rowData}
                    columnDefs={colDefs}
                    defaultColDef={defaultColDef}
                />
            </div>
        </>
    );
}
