using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Espd.CriterionModel
{
    public static class CriterionSpecifications
    {
        public static ExclusionGroundsSpecification Exclusion { get; set; }
    }

    public class ExclusionGroundsSpecification
    {
        public TenderingCriterion[] Convictions { get; set; } = new[]
        {
            new TenderingCriterion()
            {
                Name="Participation in a criminal organisation",
                Description = new TextType[]{ "Has the economic operator breached its obligations relating to the payment of taxes, both in the country in which it is established and in Member State of the contracting authority or contracting entity if other than the country of establishment?" },
                Id ="e6b21867-95b5-4549-8180-f4673219b179",
                SubTenderingTenderingCriteria = CriterionHelper.Subcriterion,
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id ="7c637c0c-7703-4389-ba52-02997a055bd7",
                        PropertyGroupTypeCode ="ON*",
                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                        {
                           new TenderingCriterionProperty()
                           {
                             Description ="Your answer",
                             ValueDataTypeCode ="INDICATOR"
                           } 
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                                Id ="41dd2e9b-1bfd-44c7-93ee-56bd74a4334b",
                                PropertyGroupTypeCode ="ONTRUE",
                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                {
                                   new TenderingCriterionProperty()
                                   {
                                     Description ="Date of conviction",
                                     ValueDataTypeCode ="DATE"
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     Description ="Reason",
                                     ValueDataTypeCode ="DESCRIPTION"
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     Description ="Who has been convicted",
                                     ValueDataTypeCode ="DESCRIPTION"
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     Description ="Length of the period of exclusion",
                                     ValueDataTypeCode ="PERIOD"
                                   }
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id ="5f9f09f7-f701-432c-9fdc-c22c124a74c9",
                                        PropertyGroupTypeCode ="ON*",
                                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                                        {
                                            new TenderingCriterionProperty()
                                               {
                                                 Description ="Have you taken measures to demonstrate your reliability (Self-Cleaning)?",
                                                 ValueDataTypeCode ="INDICATOR"
                                               }
                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id ="74e6c7b4-757b-4b40-ada6-fad6a997c310",
                                                PropertyGroupTypeCode ="ONTRUE",
                                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                {
                                                    new TenderingCriterionProperty()
                                                       {
                                                         Description ="Please describe them",
                                                         ValueDataTypeCode ="DESCRIPTION"
                                                       }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    },
                    new TenderingCriterionPropertyGroup()
                    {
                        Id ="9026e403-3eb6-4705-a9e9-e21a1efc867d",
                        PropertyGroupTypeCode ="ON*",
                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                        {
                           new TenderingCriterionProperty()
                           {
                             Description ="Is this information available at no cost to the authorities from an EU Member State database?",
                             ValueDataTypeCode ="INDICATOR"
                           }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                            Id ="0a166f0a-0c5f-42b0-81e9-0fc9fa598a48",
                            PropertyGroupTypeCode ="ONTRUE",
                            TenderingCriterionProperties = new TenderingCriterionProperty[]
                            {
                               new TenderingCriterionProperty()
                               {
                                 Description ="URL",
                                 ValueDataTypeCode ="EVIDENCE_URL"
                               },
                               new TenderingCriterionProperty()
                               {
                                 Description ="Verification code",
                                 ValueDataTypeCode ="DESCRIPTION"
                               },
                               new TenderingCriterionProperty()
                               {
                                 Description ="Issuer",
                                 ValueDataTypeCode ="DESCRIPTION"
                               }
                            }
                            } 
                        }
                    }
                }
            }




        };

        public TenderingCriterion[] Contributions { get; set; } = new[]
        {
           new TenderingCriterion()
           {
               Name="Payment of taxes",
               Description = new TextType[]{ "Has the economic operator breached its obligations relating to the payment of taxes, both in the country in which it is established and in Member State of the contracting authority or contracting entity if other than the country of establishment?" },
                Id ="e6b21867-95b5-4549-8180-f4673219b179",
               SubTenderingTenderingCriteria = CriterionHelper.Subcriterion,
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
               {

                   new TenderingCriterionPropertyGroup()
                   {
                       Id="53c9aad8-dc80-48f8-85d9-755c2aab8e95",
                       PropertyGroupTypeCode ="ON*",
                       TenderingCriterionProperties = new TenderingCriterionProperty[]
                       {
                           new TenderingCriterionProperty()
                           {
                             Description ="Threshold",
                             ValueDataTypeCode ="AMOUNT"
                           },
                           new TenderingCriterionProperty()
                           {
                             Description ="Additional Information",
                             ValueDataTypeCode ="DESCRIPTION"
                           },

                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                       {

                           new TenderingCriterionPropertyGroup()
                           {
                                Id ="098fd3cc-466e-4233-af1a-affe09471bce",
                                PropertyGroupTypeCode ="ON*",
                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                {
                                   new TenderingCriterionProperty()
                                   {
                                     Description ="Your answer",
                                     ValueDataTypeCode ="INDICATOR"
                                   },

                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id ="f8499787-f9f8-4355-95e2-9784426f4d7b",
                                        PropertyGroupTypeCode="ONTRUE",
                                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                                        {
                                            new TenderingCriterionProperty()
                                            {
                                                 Description ="Country or member state concerned",
                                                 ValueDataTypeCode ="CODE_COUNTRY"
                                            },
                                            new TenderingCriterionProperty()
                                            {
                                                 Description ="Amount concerned",
                                                 ValueDataTypeCode ="AMOUNT"
                                            },

                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id ="7c2aec9f-4876-4c33-89e6-2ab6d6cf5d02",
                                                PropertyGroupTypeCode="ON*",
                                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                {
                                                    new TenderingCriterionProperty()
                                                    {
                                                         Description ="Has this breach of obligations been established by means other than a judicial or administrative decision?",
                                                         ValueDataTypeCode ="INDICATOR"
                                                    }
                                                },
                                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                {
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id =" 80633323-a7b6-4206-9728-e4534eaad8b2",
                                                         PropertyGroupTypeCode="ONTRUE",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="Please describe which means were used",
                                                                     ValueDataTypeCode ="DESCRIPTION"
                                                                }
                                                            },
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id ="a49e6e25-0059-47da-9397-72c2db5fd5b1",
                                                         PropertyGroupTypeCode="ON*",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="Has the economic operator fulfilled its obligations by paying or entering into a binding arrangement with a view to paying the taxes or social security contributions due, including, where applicable, any interest accrued or fines?",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id ="42a44eb9-b8c9-4a67-8776-e77fc5356efe",
                                                                     PropertyGroupTypeCode="ONTRUE",
                                                                     TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                                        {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="Please describe them",
                                                                                 ValueDataTypeCode ="DESCRIPTION"
                                                                            }
                                                                     },
                                                                 }
                                                         }
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                        Id ="536417dc-8130-4981-85c5-fceba5541c58",
                                                         PropertyGroupTypeCode="ONFALSE",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="If this breach of obligations was established through a judicial or administrative decision, was this decision final and binding?",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id =" 8aaac22d-1b59-442e-9210-a6e70ec05962",
                                                                     PropertyGroupTypeCode="ONTRUE",
                                                                     TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                                     {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="Please indicate the date of conviction or decision",
                                                                                 ValueDataTypeCode ="DATE"
                                                                            },
                                                                             new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="In case of a conviction insofar as established directly therein, the length of the period of exclusion",
                                                                                 ValueDataTypeCode ="PERIOD"
                                                                            }
                                                                     },
                                                                 }
                                                         }
                                                     }
                                                },

                                            },
                                            }

                                        }

                                    },
                                },

                           new TenderingCriterionPropertyGroup(){

                               Id ="9026e403-3eb6-4705-a9e9-e21a1efc867d",
                               PropertyGroupTypeCode="ON*",
                               TenderingCriterionProperties = new TenderingCriterionProperty[]
                                  {
                                      new TenderingCriterionProperty()
                                      {
                                           Description ="Is this information available at no cost to the authorities from an EU Member State database?",
                                           ValueDataTypeCode ="INDICATOR"
                                      }
                                  },
                               SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                               {
                                       new TenderingCriterionPropertyGroup()
                                       {
                                           Id ="0a166f0a-0c5f-42b0-81e9-0fc9fa598a48",
                                           PropertyGroupTypeCode="ONTRUE",
                                           TenderingCriterionProperties = new TenderingCriterionProperty[]
                                           {
                                                  new TenderingCriterionProperty()
                                                  {
                                                       Description ="URL",
                                                       ValueDataTypeCode ="EVIDENCE_URL"
                                                  },
                                                   new TenderingCriterionProperty()
                                                  {
                                                       Description ="Verification code",
                                                       ValueDataTypeCode ="DESCRIPTION"
                                                  },
                                                     new TenderingCriterionProperty()
                                                  {
                                                       Description ="Issuer",
                                                       ValueDataTypeCode ="DESCRIPTION"
                                                  }
                                           },
                                       }
                               }


                           }

                           },
                       }
                   }
           },
           new TenderingCriterion()
           {
               Name="Payment of social security contributions",
               Description = new TextType[]{ "Has the economic operator breached its obligations relating to the payment social security contributions, both in the country in which it is established and in Member State of the contracting authority or contracting entity if other than the country of establishment?" },
               Id ="7d85e333-bbab-49c0-be8d-c36d71a72f5e",
               SubTenderingTenderingCriteria = CriterionHelper.Subcriterion,
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
               {

                   new TenderingCriterionPropertyGroup()
                   {
                       Id="53c9aad8-dc80-48f8-85d9-755c2aab8e95",
                       PropertyGroupTypeCode ="ON*",
                       TenderingCriterionProperties = new TenderingCriterionProperty[]
                       {
                           new TenderingCriterionProperty()
                           {
                             Description ="Threshold",
                             ValueDataTypeCode ="AMOUNT"
                           },
                           new TenderingCriterionProperty()
                           {
                             Description ="Additional Information",
                             ValueDataTypeCode ="DESCRIPTION"
                           },

                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                       {

                           new TenderingCriterionPropertyGroup()
                           {
                                Id ="098fd3cc-466e-4233-af1a-affe09471bce",
                                PropertyGroupTypeCode ="ON*",
                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                {
                                   new TenderingCriterionProperty()
                                   {
                                     Description ="Your answer",
                                     ValueDataTypeCode ="INDICATOR"
                                   },

                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id ="f8499787-f9f8-4355-95e2-9784426f4d7b",
                                        PropertyGroupTypeCode="ONTRUE",
                                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                                        {
                                            new TenderingCriterionProperty()
                                            {
                                                 Description ="Country or member state concerned",
                                                 ValueDataTypeCode ="CODE_COUNTRY"
                                            },
                                            new TenderingCriterionProperty()
                                            {
                                                 Description ="Amount concerned",
                                                 ValueDataTypeCode ="AMOUNT"
                                            },

                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id ="7c2aec9f-4876-4c33-89e6-2ab6d6cf5d02",
                                                PropertyGroupTypeCode="ON*",
                                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                {
                                                    new TenderingCriterionProperty()
                                                    {
                                                         Description ="Has this breach of obligations been established by means other than a judicial or administrative decision?",
                                                         ValueDataTypeCode ="INDICATOR"
                                                    }
                                                },
                                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                {
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id =" 80633323-a7b6-4206-9728-e4534eaad8b2",
                                                         PropertyGroupTypeCode="ONTRUE",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="Please describe which means were used",
                                                                     ValueDataTypeCode ="DESCRIPTION"
                                                                }
                                                            },
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id ="a49e6e25-0059-47da-9397-72c2db5fd5b1",
                                                         PropertyGroupTypeCode="ON*",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="Has the economic operator fulfilled its obligations by paying or entering into a binding arrangement with a view to paying the taxes or social security contributions due, including, where applicable, any interest accrued or fines?",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id ="42a44eb9-b8c9-4a67-8776-e77fc5356efe",
                                                                     PropertyGroupTypeCode="ONTRUE",
                                                                     TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                                        {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="Please describe them",
                                                                                 ValueDataTypeCode ="DESCRIPTION"
                                                                            }
                                                                     },
                                                                 }
                                                         }
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                        Id ="536417dc-8130-4981-85c5-fceba5541c58",
                                                         PropertyGroupTypeCode="ONFALSE",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="If this breach of obligations was established through a judicial or administrative decision, was this decision final and binding?",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id =" 8aaac22d-1b59-442e-9210-a6e70ec05962",
                                                                     PropertyGroupTypeCode="ONTRUE",
                                                                     TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                                     {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="Please indicate the date of conviction or decision",
                                                                                 ValueDataTypeCode ="DATE"
                                                                            },
                                                                             new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="In case of a conviction insofar as established directly therein, the length of the period of exclusion",
                                                                                 ValueDataTypeCode ="PERIOD"
                                                                            }
                                                                     },
                                                                 }
                                                         }
                                                     }
                                                },

                                            },
                                            }

                                        }

                                    },
                                },

                           new TenderingCriterionPropertyGroup(){

                               Id ="9026e403-3eb6-4705-a9e9-e21a1efc867d",
                               PropertyGroupTypeCode="ON*",
                               TenderingCriterionProperties = new TenderingCriterionProperty[]
                                  {
                                      new TenderingCriterionProperty()
                                      {
                                           Description ="Is this information available at no cost to the authorities from an EU Member State database?",
                                           ValueDataTypeCode ="INDICATOR"
                                      }
                                  },
                               SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                               {
                                       new TenderingCriterionPropertyGroup()
                                       {
                                           Id ="0a166f0a-0c5f-42b0-81e9-0fc9fa598a48",
                                           PropertyGroupTypeCode="ONTRUE",
                                           TenderingCriterionProperties = new TenderingCriterionProperty[]
                                           {
                                                  new TenderingCriterionProperty()
                                                  {
                                                       Description ="URL",
                                                       ValueDataTypeCode ="EVIDENCE_URL"
                                                  },
                                                   new TenderingCriterionProperty()
                                                  {
                                                       Description ="Verification code",
                                                       ValueDataTypeCode ="DESCRIPTION"
                                                  },
                                                     new TenderingCriterionProperty()
                                                  {
                                                       Description ="Issuer",
                                                       ValueDataTypeCode ="DESCRIPTION"
                                                  }
                                           },
                                       }
                               }


                           }

                           },
                       }
                   }

           }

        };

    };

};

   


