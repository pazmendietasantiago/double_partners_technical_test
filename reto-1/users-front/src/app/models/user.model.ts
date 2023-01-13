import { emptyString } from "@app/utils/utils";

export class User {
    public id: number = 0;
    public usuario: string = emptyString;
    public usuario1: string = emptyString;
    public clave: string = emptyString;
    public fechaCreacion?: Date;

    constructor(props: any) {
        this.id = props.id ?? 0;
        this.usuario = props.usuario1 ?? emptyString,
        this.usuario1 = props.usuario1 ?? emptyString,
        this.clave = props.clave ?? emptyString,

        this.fechaCreacion = props.fechaCreacion ? new Date(props.fechaCreacion) : undefined;
    }
}