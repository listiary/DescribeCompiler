========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    fiber ->

        what,
        not;
    
    water;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'macronutrients ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>')
│   ├── item_or_expression_list
│   │   ├── expression
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'\n\n    fiber ')
│   │   │   ├── producer
│   │   │   │   ├── T(HYPHEN|'-')
│   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   ├── item_or_expression_list
│   │   │   │   ├── item
│   │   │   │   │   └── text_chunk
│   │   │   │   │       └── T(DATA|'\n\n        what')
│   │   │   │   ├── T(SEPARATOR|',')
│   │   │   │   └── item_or_expression
│   │   │   │       └── item
│   │   │   │           └── text_chunk
│   │   │   │               └── T(DATA|'\n        not')
│   │   │   └── T(TERMINATOR|';')
│   │   └── item_or_expression
│   │       └── item
│   │           └── text_chunk
│   │               └── T(DATA|'\n    \n    water')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')