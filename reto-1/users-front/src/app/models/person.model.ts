import {
  defaultUserIconPath,
  emptyString,
  getRandomNumber,
  userIcons,
} from '@app/utils/utils';

export class Person {
  public id: number;
  public nombres: string;
  public apellidos: string;
  public nombreCompleto: string;
  public tipoIdentificacion: string;
  public identificacion: string;
  public email: string;
  public identificacionCompleta: string;
  public fechaCreacion?: Date;
  public imagenUsuario: string;

  constructor(props: any) {
    this.id = props.id ?? 0;
    this.nombres = props.nombres ?? emptyString;
    this.apellidos = props.apellidos ?? emptyString;
    this.nombreCompleto = props.nombreCompleto ?? emptyString;
    this.tipoIdentificacion = props.tipoIdentificacion ?? emptyString;
    this.identificacion = props.identificacion.toString() ?? emptyString;
    this.identificacionCompleta = props.identificacionCompleta ?? emptyString;
    this.email = props.email ?? emptyString;
    this.imagenUsuario = userIcons[getRandomNumber(1, 7)] || defaultUserIconPath;

    if (props.fechaCreacion) {
      this.fechaCreacion = new Date(props.fechaCreacion);
    }
  }
}
