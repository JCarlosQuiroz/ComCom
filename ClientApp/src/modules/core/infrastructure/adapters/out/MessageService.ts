import { TypeMessage } from "../../../domain/models/TypeMessage";


export abstract class MessageService {
    abstract dialog( type:string , data: TypeMessage): Promise<boolean>;
    abstract confirm( type: string, data: TypeMessage ): Promise<boolean>;
    abstract prompt( type: string, data: TypeMessage ): Promise<string>;
}