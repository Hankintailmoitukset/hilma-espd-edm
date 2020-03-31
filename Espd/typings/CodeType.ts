



import assign from 'lodash.assign'

export class CodeType { 
    public constructor(init?:Partial<CodeType>) {
        assign(this, init)
    } 
    
    
    listID: string = ''
    listName: string = ''
    listAgencyID: string = ''
    listAgencyName: string = ''
    listVersionID: string = ''
    listURI: string = ''
    listSchemeURI: string = ''
    name: string = ''
    languageID: string = ''
    value: string = ''
}