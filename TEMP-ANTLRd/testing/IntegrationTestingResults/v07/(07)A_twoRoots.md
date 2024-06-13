========================================
Source Code (between the arrows)
========================================

🡆macronutrients <Zcm0y9mS> ->

    fiber <ZxMvmqeZ>,
    water <xePTheNI>;

micronutrients <l7qy3zi2>->

    vitamins (ABCDEK) <6Nq8AWj7>,
    minerals (micronutrients) <jG4U9bwg>;🡄

========================================
Parse Tree
========================================

scripture
├── expression_list
│   ├── expression
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'macronutrients ')
│   │   │   └── tag
│   │   │       ├── T(LEFT_ARROW|'<')
│   │   │       ├── T(DATA|'Zcm0y9mS')
│   │   │       └── T(RIGHT_ARROW|'> ')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(RIGHT_ARROW|'>\n\n    ')
│   │   ├── item_or_expression_list
│   │   │   ├── item_or_expression_part
│   │   │   │   ├── item
│   │   │   │   │   ├── text_chunk
│   │   │   │   │   │   └── T(DATA|'fiber ')
│   │   │   │   │   └── tag
│   │   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │   │       ├── T(DATA|'ZxMvmqeZ')
│   │   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(SEPARATOR|',\n    ')
│   │   │   └── item
│   │   │       ├── text_chunk
│   │   │       │   └── T(DATA|'water ')
│   │   │       └── tag
│   │   │           ├── T(LEFT_ARROW|'<')
│   │   │           ├── T(DATA|'xePTheNI')
│   │   │           └── T(RIGHT_ARROW|'>')
│   │   └── T(TERMINATOR|';\n\n')
│   └── expression
│       ├── item
│       │   ├── text_chunk
│       │   │   └── T(DATA|'micronutrients ')
│       │   └── tag
│       │       ├── T(LEFT_ARROW|'<')
│       │       ├── T(DATA|'l7qy3zi2')
│       │       └── T(RIGHT_ARROW|'>')
│       ├── producer
│       │   ├── T(HYPHEN|'-')
│       │   └── T(RIGHT_ARROW|'>\n\n    ')
│       ├── item_or_expression_list
│       │   ├── item_or_expression_part
│       │   │   ├── item
│       │   │   │   ├── text_chunk
│       │   │   │   │   └── T(DATA|'vitamins (ABCDEK) ')
│       │   │   │   └── tag
│       │   │   │       ├── T(LEFT_ARROW|'<')
│       │   │   │       ├── T(DATA|'6Nq8AWj7')
│       │   │   │       └── T(RIGHT_ARROW|'>')
│       │   │   └── T(SEPARATOR|',\n    ')
│       │   └── item
│       │       ├── text_chunk
│       │       │   └── T(DATA|'minerals (micronutrients) ')
│       │       └── tag
│       │           ├── T(LEFT_ARROW|'<')
│       │           ├── T(DATA|'jG4U9bwg')
│       │           └── T(RIGHT_ARROW|'>')
│       └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')