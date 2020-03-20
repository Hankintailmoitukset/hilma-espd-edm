/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IdentifierType } from "./identifier-type";
import { TextType } from "./text-type";
import { LanguageType } from "./language-type";
import { AddressType } from "./address-type";

export class Legislation {
    iD: IdentifierType;
    titles: TextType[];
    descriptions: TextType[];
    jurisdictionLevels: TextType[];
    articles: TextType[];
    uRIs: IdentifierType[];
    languages: LanguageType[];
    jurisdictionRegionAddresses: AddressType[];
}
