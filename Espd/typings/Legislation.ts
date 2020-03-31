


import { IdentifierType } from './IdentifierType'
import { TextType } from './TextType'
import { LanguageType } from './LanguageType'
import { AddressType } from './AddressType'

import assign from 'lodash.assign'

export class Legislation { 
    public constructor(init?:Partial<Legislation>) {
        assign(this, init)
    } 
    
    
    id: IdentifierType = new IdentifierType()
    titles: TextType[] = []
    descriptions: TextType[] = []
    jurisdictionLevels: TextType[] = []
    articles: TextType[] = []
    urIs: IdentifierType[] = []
    languages: LanguageType[] = []
    jurisdictionRegionAddresses: AddressType[] = []
}