Feature: SimilarStepDefinitionSignatures

  Scenario: Check first definition
    When I use step with Similar 'Definition' with closed signature

  Scenario: Check second definition
    When I use step with 'Definition' with closed signature

  Scenario: Check third definition that should not match any enum value or description
    When I use step with 'Similar Definition' with closed signature